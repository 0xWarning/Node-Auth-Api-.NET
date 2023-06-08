const mongoose = require("mongoose");

const UserLicense = new mongoose.Schema({
    // License (Unique To One User)
    license: {
        type: String,
        required: true,
    },
    // Rank (Custom Ranks)
    rank: {
        type: String,
        required: false,
    },
    // Expiry
    expiry: {
        type: String,
        required: false,
    },
    // RedeemedBy (One Claimed By User It Is Tied To There Account)
    redeemedBy: {
        type: String,
        required: false,
    },

});

module.exports = mongoose.model("userLicense", UserLicense);