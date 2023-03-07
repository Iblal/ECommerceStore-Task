{
    "$schema": "http://json-schema.org/draft-07/schema#",
        "title": "Order Request",
            "type": "object",
                "properties": {
        "email": {
            "type": "string",
                "format": "email",
                    "description": "The email address of the customer placing the order."
        },
        "address": {
            "type": "string",
                "description": "The shipping address of the customer placing the order."
        },
        "products": {
            "type": "array",
                "items": {
                "type": "object",
                    "properties": {
                    "id": {
                        "type": "string",
                            "description": "The unique identifier of the product being ordered."
                    },
                    "price": {
                        "type": "number",
                            "minimum": 0,
                                "description": "The price of the product being ordered."
                    }
                },
                "required": ["id", "price"]
            },
            "minItems": 1,
                "description": "The list of products being ordered, including their IDs and prices."
        }
        "orderTotal": {
            "type": "number",
                "minimum": 0,
                    "description": "The total price of the order, calculated as the sum of the prices of all products being ordered."
        }
    },
    "required": ["email", "address", "products"],
        "description": "An order request from a customer, including their email address, shipping address, list of products being ordered and total."
}
