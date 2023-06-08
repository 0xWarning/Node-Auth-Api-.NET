const router = require('express').Router();
const User = require('../modal/user');
const verify = require('../util/verifyToken');
const file = require('../modal/file');
const UserLicense = require("../modal/license");
const fs = require('fs');
var MongoClient = require('mongodb').MongoClient;
// If no auth-token this won't work

router.get('/', verify, (req, res) => {

  res.send(req.user);
  //User.findbyOne({_id: req.user});
});

router.post("/gen_token", verify, async (req, res) => {
  // If req has customer header and value allow the delete
  if (req.header(process.env.CUSTOM_HEADER) == process.env.CUSTOM_HEADER_VALUE) {
    if (req.header(process.env.ADMIN_KEY_HEADER) == process.env.ADMIN_KEY) {
      const licExist = await UserLicense.findOne({ license: req.body['license'] });
      if (licExist) return res.status(400).send('Licesnse exists already');

      const mylicense = UserLicense({
        license: req.body.license,
        rank: req.body.rank,
        expiry: req.body.expiry,
        redeemedBy: "unclamied"
      });

      // Send data to db
      await mylicense.save();

      
      res.status(200).send("License Created");
      console.log(`[ADMIN] `.blue +  `License Created `.yellow);
    }
    else {
      res.status(200).send("AK47 Error");
      // Incorrect ADMIN key, header
    }
  }
  else {
    res.status(200).send("Authorisation Error");
    // Incorrect secret key, header
  }
})

router.post("/remove_user", verify, async (req, res) => {
  // If req has customer header and value allow the delete
  if (req.header(process.env.CUSTOM_HEADER) == process.env.CUSTOM_HEADER_VALUE) {
    if (req.header(process.env.ADMIN_KEY_HEADER) == process.env.ADMIN_KEY) {
    // Check if email exist
    const user = await User.findOne({ email: req.body.email });
    if (!user) return res.status(400).send('User does not exists');


    // Delete one incase multiple with same email
    // Will have to filter or make the emails bind to one account instead of multiple
    User.deleteOne({
      email: req.body.email
    }, function (err, user) {
      if (err)
        return console.error(err);

      console.log(`[ADMIN] `.blue + `User tied with email `.gray + `${req.body.email}`.cyan + ` was successfully removed`);
      res.status(200).send("User Deleted");
    })
  }
  else {
    res.status(200).send("AK47 Error");
    // Incorrect ADMIN key, header
  }
}
else {
  res.status(200).send("Authorisation Error");
  // Incorrect secret key, header
}
})

router.post("/remove_file", verify, async (req, res) => {
  if (req.header(process.env.CUSTOM_HEADER) == process.env.CUSTOM_HEADER_VALUE) {
    // If req has customer header and value allow the delete
    const fileReq2 = await file.findOne({ name: req.body.gname });
    if (!fileReq2) return res.status(400).send('File does not exists');

    // Delete one file incase multiple instances
    file.deleteOne({
      name: req.body.gname,
    }, function (err, file) {
      if (err)
        return console.error(err);


      // Remove the symbolic link
      fs.unlink('./uploads/' + req.body.gname, (err) => {
        if (err) throw err //handle your error the way you want to;
        console.log('path/file.txt was deleted');//or else the file will be deleted
      });

      console.log(`[ADMIN] `.blue + "Successfully".green + " removed ".red + `${req.body.gname}`.cyan);
      res.status(200).send("File Deleted");
    })



  }
  else {
    res.status(200).send("Authorisation Error");
    // Incorrect secret key, header
  }
})

router.post("/get_users", verify, async (req, res) => {
  // If req has customer header and value allow the delete
  if (req.header(process.env.CUSTOM_HEADER) == process.env.CUSTOM_HEADER_VALUE) {
    if (req.header(process.env.ADMIN_KEY_HEADER) == process.env.ADMIN_KEY) {
     
      MongoClient.connect(process.env.DB_CON_STRING, function (err, db) { // Connect to db
        if (err) throw err;
        var dbo = db.db("test"); // Selec DB Test
        // Find table users and required params
        dbo.collection("users").find({}, { projection: { _id: 0, name: 1, email: 1, license: 1, role: 1 } }).toArray(function (err, result) {
            if (err) throw err;
            res.send(result); // Return result
            db.close(); // close db
        });
    });
    console.log(`[ADMIN] `.blue +  `User list grabbed `.yellow);

    }
    else {
      res.status(200).send("AK47 Error");
      // Incorrect ADMIN key, header
    }
  }
  else {
    res.status(200).send("Authorisation Error");
    // Incorrect secret key, header
  }
})



module.exports = router;