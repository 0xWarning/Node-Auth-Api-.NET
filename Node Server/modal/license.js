const mongoose = require("mongoose");

const UserLicense = new mongoose.Schema({
    // Nothing fancy here
    license: {
        type: String,
        required: true,
    },
    rank: {
        type: String,
        required: false,
    },
    // Hashed Password
    expiry: {
        type: String,
        required: false,
    },
    redeemedBy: {
        type: String,
        required: false,
    },

});

module.exports = mongoose.model("userLicense", UserLicense);