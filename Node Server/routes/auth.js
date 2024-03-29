// Required Modules
const router = require("express").Router();
const mongoose = require("mongoose");
const jwt = require("jsonwebtoken");
const bcrypt = require("bcrypt");
const User = require("../model/user");
const UserLicense = require("../model/license");
const { registerValidation, loginValidation } = require("../util/validation");
const { isEmpty } = require("lodash");

//////////////////
// (GET) Register
//////////////////
router.get(
  "/register/:name/:email/:password/:registedwip/:referral",
  async (req, res) => {
    try {
      // const userExist = await User.findOne({user: req.body.user});
      // if(userExist) return res.status(400).send('Username already taken')

      const emailExist = await User.findOne({ email: req.params["email"] });
      if (emailExist) return res.status(400).send("Email already exists");

      const salt = await bcrypt.genSalt(10);
      const hashPassword = await bcrypt.hash(req.params["password"], salt);
      const hashEmail = await bcrypt.hash(req.params["email"], salt);
      const myuser = new User({
        name: req.params["name"],
        email: req.params["email"],
        password: hashPassword,
        registedwip: req.params["registedwip"],
        referral: req.params["referral"],
      });

      await myuser.save();
      res.send(myuser);

      console.log(`A User was created `.gray + `${req.body.name}`.cyan);
    } catch (err) {
      res.send({ message: err });
    }
  }
);

//////////////////
// (POST) Register
//////////////////
router.post("/register", async (req, res) => {
  try {
    // const userExist = await User.findOne({user: req.body.user});
    // if(userExist) return res.status(400).send('Username already taken')

    // Check if email exists
    const emailExist = await User.findOne({ email: req.body.email });
    const licExist = await UserLicense.findOne({ license: req.body.license });
    if (!licExist) {
      return res.status(400).send("License does not exist");
    } else if (emailExist) {
      return res.status(400).send("Email already exists");
    } else {
      const f = await UserLicense.findOne({ license: req.body.license, redeemedBy: "unclamied"})
      if (f)
      {
// Salt + HASH the password
      const salt = await bcrypt.genSalt(10);
      const hashPassword = await bcrypt.hash(req.body.password, salt);
      const hashEmail = await bcrypt.hash(req.body.email, salt);

      // Serialise request data
      const myuser = new User({
        name: req.body.name,
        email: req.body.email,
        password: hashPassword,
        license: req.body.license,
        registedwip: req.body.registedwip,
        referral: req.body.referral,
      });

      // Send data to db
      await myuser.save();


      
      // Serialise request data
      const mylicense = new UserLicense({
        license: req.body.license,
        redeemedBy: req.body.name,
      });

      await UserLicense.findOneAndUpdate({license: req.body.license},
      {redeemedBy: req.body.name}).then((ans) => {
          console.log(`@`.white + `${req.body.name}`.green + ` has claimed `.gray + `${req.body.license}`.red);
      }).then((err) => {
          console.log(err);
      })    

      // Send Results to client
      res.send(myuser);

      // Log to console
      console.log(`A User was created `.gray + `${req.body.name}`.cyan);
      }
      else
      {
        return res.status(400).send("License has been claimed");
      }
      
    }
  } catch (err) {
    res.send({ message: err });
  }
});

//////////////////
// (GET) Login
//////////////////
router.get("/login/:email/:password", async (req, res) => {
  const user = await User.findOne({ email: req.params["email"] });
  if (!user) return res.status(400).send("Email or password is wrong");

  const validPass = await bcrypt.compare(req.params["password"], user.password);
  if (!validPass) return res.status(400).send("Password is wrong");

  const token = jwt.sign(
    { _id: user._id, name: user.name, email: user.email },
    process.env.TOKEN_SECRET
  );
  res.header("auth-token", token).send(`logged in |${token}`);
  // res.send(`logged in ${token}`);
  console.log(`${user.name}`.cyan + ` has logged in `.gray);
});

//////////////////
// (POST) Login
//////////////////
router.post("/login", async (req, res) => {
  const user = await User.findOne({ email: req.body.email });
  if (!user) return res.status(400).send("Email or password is wrong");

  const validPass = await bcrypt.compare(req.body.password, user.password);
  if (!validPass) return res.status(400).send("Password is wrong");

  const token = jwt.sign(
    { _id: user._id, name: user.name, email: user.email },
    process.env.TOKEN_SECRET
  );
  res.header("auth-token", token).send(token);
  console.log(`${user.name}`.cyan + ` has logged in `.gray);
});

//////////////////
// (POST) Login License
//////////////////
router.post("/login-license", async (req, res) => {
  try {

    const licExist = await UserLicense.findOne({ license: req.body.license });
    if (!licExist) {
      return res.status(400).send("License does not exist");
    } else {
      const f = await UserLicense.findOne({ license: req.body.license, redeemedBy: "unclamied"})
      const f2 = await UserLicense.findOne({ license: req.body.license})
      if (f)
      {
        return res.status(400).send("License has not been claimed");
      }
      else if (f2)
      {
        const token = jwt.sign(
          { license: req.body.license },
          process.env.TOKEN_SECRET
        );
        res.header("auth-token", token).send(`logged in | ${token}`);
      }
      else
      {
        return res.status(400).send("License does not exist");
      }
      
    }
  } catch (err) {
    res.send({ message: err });
  }
});


module.exports = router;
