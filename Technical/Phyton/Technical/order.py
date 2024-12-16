# order.py
orders = []

def place_order(username, product_name, quantity):
    orders.append({"username": username, "product": product_name, "quantity": quantity})

def list_orders():
    return orders
