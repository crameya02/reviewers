# user.py
users = []

def add_user(username, password):
    users.append({"username": username, "password": password})

def authenticate_user(username, password):
    for user in users:
        if user["username"] == username and user["password"] == password:
            return True
    return False
