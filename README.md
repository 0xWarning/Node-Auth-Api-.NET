# 🍺 Node-Auth-Api-.NET bundled with Node Backend
- Simple auth for Applications. Node Server, C# Client
- Scroll down for more information and the api section
- This is very simple and was made as an example for a friend who has barely any coding knowledge it was just slapped together

# 🍺 Some features (more to come)

- Login - Email + Pass,
- Login (License Only),
- Register - Username + Email + Pass + License Key,
- Remove User By Email,
- Generate License's With Custom Prefix, Rank and Expiry.


(Just make a function to detect when its expired and detect what each rank should do)

## --------- Admin Panel + Node -------------

<p align="center">
  <img src="https://cdn.discordapp.com/attachments/930906438820311060/1114691704671445073/image.png">
</p>

## --------- API -------------
# 🍺 Node-API-Backend

Using Express, Mongoose, Bcrypt, and Node.js, 
I'm currently working on a backend for an authentication system that features hashed passwords, JWT and numerous checks.

Current JWT Protected Endpoints (requires a login to get a token)

`ADMIN`

`FILES`

`SECRET`

This is till project is not yet complete

# ⚙️ Configuration

```dotenv
PORT = 1337
VERSION = 1.3.3.7
TOKEN_SECRET = SALTYTOKENS
CUSTOM_HEADER = "APL"
CUSTOM_HEADER_VALUE = "Toasty"
DB_CON_STRING = MONGO-DB-CON-LINK-HERE
ADMIN_KEY = "ADMINKEYHERE"
ADMIN_KEY_HEADER = "AK47"
```

# ⚡ Getting Started

Install Node.js **[Link](https://nodejs.org/en/download/)**

Follow these instructions in a terminal environment.

```bash
# Goto Dir
$ cd Node-API-Backend

# Install packages
$ npm i

# Boot it up (Will be changed to 'npm start')
$ node app.js

```

# 📜 API End Points

> Note: Simply create a json body request for posts using the same values as the GET requests.

> Most endpoints may require the `auth-token` header to be set which you get after you login

## API

- 🖥️ Register

`http://SERVER:1337/api/user/register (POST)`

`http://SERVER:1337/api/user/register/:name/:email/:password/:registedwip/:referral (GET)`

- 🖥️ Login

`http://SERVER:1337/api/user/login (POST)`

`http://SERVER:1337/api/user/login/:email/:password (GET)`


- 🖥️ Upload

`http://SERVER:1337/api/files/upload (POST)`
> Note: Check the response

`http://SERVER:1337/api/files/upload_db (POST)` Uploads to mongo db
> Note: Check the response

- 🖥️ Upload List

`http://SERVER:1337/api/files/list (GET)`
> Note: Returns json array list


## ADMIN API


- 🖥️ Get All Users

`http://SERVER:1337/api/admin/get_users (POST)`

- 🖥️ Gen Token

`http://SERVER:1337/api/admin/gen_token (POST)`

- 🖥️ Remove User

`http://SERVER:1337/api/admin/remove_user (POST)`

> Note: Making a post request with the query `{email: "test@gmail.com"}` will delete the associated account.

> Make sure to include your `CUSTOM_HEADER` and `CUSTOM_HEADER_VALUE` in the header of the request


- 🖥️ Remove File

`http://SERVER:1337/api/admin/remove_file (POST)`

> Note: Making a post request with the query `{name: "test.txt"}` will delete the associated file.

> Make sure to include your `CUSTOM_HEADER` and `CUSTOM_HEADER_VALUE` in the header of the request


## SECRET API

- 🖥️ Get Download

`http://SERVER:1337/api/secret/getDownload (GET)`

- 🖥️ Dev Notes

`http://SERVER:1337/api/secret/dev_notes (GET)`

`http://SERVER:1337/api/secret/submit_dev_note (POST)`

- 🖥️ Chat Log

`http://SERVER:1337/api/secret/chat_log (GET)`

`http://SERVER:1337/api/secret/submit_chat_log (POST)`
