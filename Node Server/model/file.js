// Required Modules
const mongoose = require("mongoose");

const File = new mongoose.Schema({
  // Name (File Name)
  name: {
    type: String,
    required: true,
  },
  // Description (File Description)
  description: {
    type: String,
    required: true,
  },
  // Size (File Size in Mbs Usually)
  size: {
    type: String,
    required: false,
  },
  // Type (File Type)
  type: {
    type: String,
    required: false,
  },
  // Uploaded By (Upload Author)
  upload_by: {
    type: String,
    required: true,
  },
});

module.exports = mongoose.model("file", File);
