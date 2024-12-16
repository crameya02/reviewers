# product.py
products = []

def add_product(name, price):
    products.append({"name": name, "price": price})

def list_products():
    return products
