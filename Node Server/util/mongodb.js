// Require Modules
const Mongoose = require("mongoose")

require("dotenv/config");

const localDB = process.env.DB_CON_STRING
const connectMongoDB = async () => {
  await Mongoose.connect(localDB, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
  })
  .then(() => {
    console.log("Connected".green + " to".gray + " mongoDB".cyan);
  })
  .catch((err) => {
    console.log(`${err}`.red);
  })
}
module.exports = connectMongoDB