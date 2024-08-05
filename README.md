# Fast Food Ordering System

## Introduction

The Fast Food Ordering System is a Windows Form application developed using C# for the fast food restaurant "Burger Mania." It provides a convenient and user-friendly platform for customers to browse the menu, add items to the cart, and place orders for delivery. The system also includes login and signup functionality to ensure secure access and streamline the payment process. Additionally, customers can write reviews about the food and share their experiences.

## Project Objective

The objective of this project is to create an efficient online ordering system for Burger Mania that enhances the overall customer experience. The system aims to achieve the following objectives:

- Provide an attractive and engaging user interface that captures the essence of Burger Mania's brand and encourages customers to place orders.
- Enable customers to browse the menu and select items of their choice.
- Implement a secure login and signup mechanism to ensure only registered users can proceed with the payment process.
- Facilitate the management of cart items, allowing users to add, remove quantities before finalizing their order.
- Integrate a secure payment gateway to handle online transactions and ensure the confidentiality of customer payment information.
- Capture and store customer delivery details, including address and contact information, to ensure accurate and timely order delivery.
- Provide customers with order confirmation and estimated delivery time to enhance transparency and customer satisfaction.
- Allow users to write reviews and provide feedback on their dining experience, contributing to the overall reputation of Burger Mania.

## Features

### Home Page

- Display an appealing ad promoting Burger Mania's offerings and encouraging users to place an order.
- Provide a seamless navigation experience to access other sections of the application.

### Menu

- Present the restaurant's menu with a variety of burger options and detailed descriptions.
- Update the cart summary dynamically to reflect the selected items and their respective prices.

### Cart Management

- Display a data grid view on the left side of the menu section, showing the added items' names, prices, and quantities.
- Calculate and display the total price of the items added to the cart.

### Login and Signup

- Request user account details, including account number, CVV, expiry date, address, phone number, email, and name.
- Validate and securely store user information for future logins and order processing.

### Payment and Order Placement

- Prompt users to sign up or log in before proceeding with the payment.
- Integrate a secure payment gateway for users to enter their payment information.
- Upon successful payment, display an order confirmation message with an estimated delivery time.

### Review Section

- Allow users to write reviews and provide feedback about the food and their overall experience.
- Display the reviews to showcase the restaurant's reputation and encourage customer engagement.

These features collectively create a user-friendly and secure online ordering system for Burger Mania, enhancing the overall customer experience and streamlining the food ordering process.

## Technologies Used

- **C# Windows Forms**: Provides a user-friendly and interactive graphical user interface.
- **SQL Server**: Manages the database, ensuring data integrity and security.
- **Visual Studio**: Integrated development environment used for building the application.

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/FaisalBasit/Fast-Food-Ordering-System.git
   ```

2. **Open the solution file**:
   - Navigate to the project directory.
   - Open the solution file (`.sln`) in Visual Studio.

3. **Configure the database**:
   - Ensure SQL Server is installed and running.
   - Update the connection string in the `App.config` file with your SQL Server credentials.

4. **Build and run the application**:
   - Build the solution in Visual Studio.
   - Run the application.

## Usage

- **Home Page**: Navigate to the menu and browse the available burger options.
- **Menu**: Add items to the cart and view the cart summary dynamically.
- **Cart Management**: Manage cart items, including adding and removing quantities.
- **Login and Signup**: Securely sign up or log in to proceed with the order.
- **Payment and Order Placement**: Enter payment information and place the order.
- **Review Section**: Write reviews and provide feedback on your dining experience.

## License

This project is licensed under the MIT License. 

## Contact

For any inquiries or support, please contact:

- **Name**: Faisal Basit
- **Email**: muhammadfaisal159@gmail.com
