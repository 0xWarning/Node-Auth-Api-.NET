// Required Modules
const mongoose = require("mongoose");

const Chat = new mongoose.Schema({
  // Author (Chat Author)
  author: {
    type: String,
    required: true,
  },
  // Timestamp (Sent Timestamp)
  timestamp: {
    type: String,
    required: true,
  },
  // Message (Self Explanatory)
  message: {
    type: String,
    required: true,
  },
});

module.exports = mongoose.model("chat", Chat);
