// Required Modules
const express = require("express");
const fileUpload = require("express-fileupload");
const mongoose = require("mongoose");
const connectMongoDB = require("./util/mongodb");
const jwt = require("jsonwebtoken");
const bcrypt = require("bcrypt");
const User = require("./modal/user");
const cors = require("cors");
const bodyParser = require("body-parser");
const morgan = require("morgan");
const _ = require("lodash");
const colors = require("colors");
const app = express();

// Require .env
require("dotenv/config");

// Without this i can't read post and get data (Might be a better solution)
//app.use(morgan('dev'));
app.use(cors());
app.use(express.json());
app.use(express.static("uploads"));
app.use(express.urlencoded({ extended: false }));
app.use(
  fileUpload({
    createParentPath: true,
  })
);

// localhost:1337/ GET response
app.get("/", (req, res) => {
  res.sendFile(__dirname + '/static/index.html');
});

// Connect to MongoDB
connectMongoDB();

// Import API Routes
const adminRoute = require("./routes/admin");
const authRoute = require("./routes/auth");
const filesRoute = require("./routes/files");
const secretRoute = require("./routes/secret");

// Route API Middlewares
app.use("/api/admin", adminRoute);
app.use("/api/user", authRoute);
app.use("/api/files", filesRoute);
app.use("/api/secret", secretRoute);

// Listen on port
app.listen(process.env.PORT, () => {
  console.clear();
  console.log(`Listening on `.gray + `${process.env.PORT}`.yellow);
});

// Handling Error
process.on("unhandledRejection", err => {
  console.log(`An error occurred: ${err.message}`.red)
  app.close(() => process.exit(1))
})
