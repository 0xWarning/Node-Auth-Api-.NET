// Required Modules
const mongoose = require("mongoose");

const User = new mongoose.Schema({
    // Name/Username
    name: {
        type: String,
        required: true,
    },
    // Email (No Email Can Be The Same) 
    email: {
        type: String,
        required: true,
    },
    // Password (Hashed Password)
    password: {
        type: String,
        required: true,
    },
    // License (Tied To The User If Claimed)
    license: {
        type: String,
        required: false,
    },
    // For now we only want users with a referral code to signup
    referral: {
        type: String,
        required: false,
    },
    // Coming Soon (Check registered IP against current login ip or reg ip)
    registedwip: {
        type: String,
        required: true,
    },

});

module.exports = mongoose.model("user", User);