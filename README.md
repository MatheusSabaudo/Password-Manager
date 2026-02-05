# Password Manager

An easy-to-use password manager with encryption for secure password storage. Built as a CS50 final project using Flask and SQLite.

## 🔒 Features

- **Secure Account Management**: Register and log in to your personal password vault
- **Password Storage**: Store passwords securely with website and username information
- **Strong Encryption**: Uses high-security encryption algorithm (PBKDF2-HMAC with SHA-256 and Fernet)
- **Master Password Protection**: Encryption key is derived from your hashed master password and salt
- **Master Password Reset**: Change your master password anytime - all stored passwords are automatically re-encrypted
- **Password Validation**: Enforces strong password requirements (minimum 8 characters, uppercase, lowercase, digit, and symbol)
- **Vault Management**: View, add, update, and delete stored passwords

## 🔐 Security

The password manager implements multiple layers of security:

- **Encryption at Rest**: All passwords are encrypted before being stored in the database using Fernet (symmetric encryption)
- **Key Derivation**: Encryption keys are derived using PBKDF2-HMAC with SHA-256, combining your master password with a unique salt
- **Hashed Master Password**: Your master password is hashed using industry-standard algorithms before storage
- **Protected Decryption**: Passwords can only be decrypted with the correct master password
- **Automatic Re-encryption**: When you change your master password, all stored passwords are automatically re-encrypted with the new key

> **Note**: Even if someone gains access to the database, they cannot read your passwords without your master password.

## 🛠️ Tech Stack

- **Backend**: Flask (Python web framework)
- **Database**: SQLite
- **Security**: 
  - Werkzeug (password hashing)
  - cryptography/Fernet (password encryption)
  - PBKDF2-HMAC-SHA256 (key derivation)

## 📋 Prerequisites

- Python 3.x
- pip (Python package manager)

## 🚀 Installation

1. Clone the repository:
```bash
git clone https://github.com/MatheusSabaudo/Password-Manager.git
cd Password-Manager
```

2. Install dependencies:
```bash
pip install -r requirements.txt
```

3. Run the application:
```bash
flask run
```

4. Open your browser and navigate to `http://localhost:5000`

## 📝 Usage

### First Time Setup
1. Register a new account with a strong master password
2. Log in with your credentials

### Managing Passwords
1. **Add Password**: Enter the website, username, and password you want to store
2. **View Passwords**: See all your stored passwords in your vault
3. **Update Password**: Modify existing password entries
4. **Delete Password**: Remove passwords you no longer need
5. **Change Master Password**: Update your master password (all passwords will be re-encrypted automatically)

### Password Requirements
Your master password must meet these requirements:
- Minimum 8 characters
- At least one uppercase letter
- At least one lowercase letter
- At least one digit
- At least one special symbol

## 📁 Project Structure

```
Password-Manager/
├── app.py              # Main application file with routes and logic
├── helpers.py          # Helper functions
├── requirements.txt    # Python dependencies
├── static/            # CSS, JavaScript, and images
├── templates/         # HTML templates
└── password.db        # SQLite database (created on first run)
```

## 🔍 Database Schema

The application uses SQLite with two main tables:
- **users**: Stores user account information (username, hashed master password)
- **passwords**: Stores encrypted passwords with associated metadata (website, username, encrypted password, salt, user_id)

## ⚠️ Important Notes

- This is an educational project developed as a CS50 final project
- While it implements strong encryption, consider using established password managers for production use
- Never share your master password with anyone
- Make sure to remember your master password - there is no recovery option
- Keep regular backups of your database if using in production

## 🤝 Contributing

This is a learning project, but feedback and suggestions are welcome! Feel free to:
- Open issues for bugs or feature requests
- Submit pull requests for improvements
- Provide feedback on security implementations

## 📄 License

This project is open source and available for educational purposes.

## 👤 Author

**Matheus Sabaudo**

## 🙏 Acknowledgments

- Built as a final project for CS50
- Thanks to the Flask and Python cryptography communities
- Inspired by the need for secure, simple password management

---

⭐ If you found this project helpful, please consider giving it a star!
