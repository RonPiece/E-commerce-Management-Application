# E-commerce Management Application

A desktop e-commerce management system built with C# and Windows Forms that provides a complete solution for managing sellers, buyers, and products in an e-commerce environment.

## Project Overview

This application serves as a management platform for e-commerce operations, allowing administrators to:
- Manage seller and buyer registration with complete address information
- Handle product catalog management with support for standard and special products
- Process buyer-seller transactions
- Maintain persistent data storage via file-based serialization

## Features

### Core Functionality
- **Seller Management**: Register new sellers with complete address details (street, city, state, building number)
- **Buyer Management**: Add and manage buyer accounts with address information
- **Product Catalog**: 
  - Add standard products with name, price, and category
  - Support for special products with additional pricing and features
  - Product assignment to sellers' inventories
- **Transaction Management**: Facilitate product purchases from sellers to buyers
- **Data Persistence**: Automatic save/load functionality using text file storage
- **Comprehensive Reporting**: View all sellers, buyers, and their associated products

### Technical Features
- **Administrative Division**: Centralized management of all buyers and sellers
- **Data Validation**: Input validation for addresses and product information
- **File I/O Operations**: Robust saving and loading of seller/product data
- **Exception Handling**: Comprehensive error handling for file operations and data validation

## Project Structure

```
MiniProject/
├── MainForm.cs                    # Main application form and core logic
├── BasicClasses/                  # Core business logic classes
│   ├── Address.cs                 # Address management
│   ├── administrativeDivision.cs  # Central management system
│   ├── Buyer.cs                   # Buyer entity class
│   ├── Product.cs                 # Product and SpecialProduct classes
│   ├── Seller.cs                  # Seller entity class
│   └── Program.cs                 # Application entry point
└── Form/                          # UI Forms
    ├── AddBuyerForm.cs           # Buyer registration form
    ├── AddSellerForm.cs          # Seller registration form
    ├── AddProductToSellerForm.cs # Product addition to seller
    ├── AddProductToBuyerForm.cs  # Product purchase form
    ├── CheckIfSellerExists.cs    # Seller verification form
    └── ShowAllData.cs            # Data display form
```

## Technologies Used

- **Language**: C#
- **Framework**: .NET Framework 4.x
- **UI Framework**: Windows Forms
- **Data Storage**: File-based serialization (text files)
- **Architecture**: Object-oriented design with separation of concerns

## Key Classes

- **MainForm**: Primary application interface and controller
- **Address**: Manages address information with validation
- **Product/SpecialProduct**: Product entities with pricing and categorization
- **Buyer/Seller**: User entities with address and product associations
- **administrativeDivision**: Central management system for all entities

## Getting Started

### Prerequisites
- .NET Framework 4.x or later
- Windows operating system
- Visual Studio 2022 (recommended for .NET Framework projects)

### Running the Application

#### Method 1: Visual Studio 2022 (Recommended)
1. Open `MiniProject.sln` in Visual Studio 2022
2. Build and run the project (F5 or Ctrl+F5)

#### Method 2: MSBuild Command Line
For command line building and running:

```bash
# Navigate to the solution directory
cd C:\Users\USER\Documents\GitHub\E-commerce-MiniProject

# Build using MSBuild (requires Visual Studio installed)
msbuild MiniProject.sln

# Run the executable
.\MiniProject\bin\Debug\MiniProject.exe
```

#### Method 3: Developer Command Prompt
1. Open "Developer Command Prompt for VS 2022" from Windows Start menu
2. Navigate to your project directory:
   ```bash
   cd C:\Users\USER\Documents\GitHub\E-commerce-MiniProject
   ```
3. Build the project:
   ```bash
   msbuild MiniProject.sln
   ```
4. Run the application:
   ```bash
   .\MiniProject\bin\Debug\MiniProject.exe
   ```

### Important Notes
- This project uses .NET Framework and Windows Forms, which are optimized for Visual Studio development environment
- The `dotnet` CLI has limited support for .NET Framework projects, especially with Windows Forms
- For best development experience and full feature support, use Visual Studio 2022

## Data Persistence

The application automatically saves seller and product data to `Sellers.txt` in the application directory when closing, and loads this data on startup. The file format includes:
- Seller information (name and address)
- Product details (standard and special products)
- Hierarchical data structure for easy parsing

## System Requirements

- **Operating System**: Windows 10 or later
- **Development Environment**: Visual Studio 2022 (Community, Professional, or Enterprise)
- **Runtime**: .NET Framework 4.x
- **Architecture**: x86 or x64

## Contributors

- Ron Blanki
- Eden Gavrialov

## License

This project is developed as part of an academic assignment.

---

**Note**: This application is specifically designed for the Windows platform using .NET Framework. For cross-platform development, consider migrating to .NET 6+ with Windows Forms support.
