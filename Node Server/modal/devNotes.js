const mongoose = require("mongoose");

const devN = new mongoose.Schema({
  // Submit By (Note Author)
  submit_by: {
    type: String,
    required: true,
  },
  // Issue (Note Name)
  issue: {
    type: String,
    required: true,
  },
  // Note (Note Info/Description)
  note: {
    type: String,
    required: false,
  },
});

module.exports = mongoose.model("devn", devN);
