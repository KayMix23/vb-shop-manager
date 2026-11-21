KAY SHOP MANAGER - VB.NET WINDOWS FORMS

This is a Visual Basic .NET Windows Forms project targeting .NET 8.

OPENING THE PROJECT
1. Extract the ZIP file to a normal folder.
2. Open KayShopManager.vbproj in Visual Studio 2022 or later.
3. If Visual Studio asks to install the .NET 8 desktop components, allow it.
4. In Solution Explorer, expand MainForm.vb and double-click MainForm.vb (or right-click it and choose View Designer).
5. Press F5 to run the application.

FEATURES
- Add, update, delete and reload products.
- Product name, description, color, brand, other details and remarks.
- Delivery date, barcode, category, quantity and unit of measure.
- Wholesale cost, selling price, total stock cost and profit per unit.
- Storage location and product search.
- Local data persistence in a JSON file.

DATA STORAGE
The application stores product records on this Windows computer at:
%LOCALAPPDATA%\KayShopManager\products.json

No database server or extra NuGet package is required.

IMPORTANT
This is a standalone starter application. It does not connect to MySQL or a shared network database.
Back up the products.json file if you need to move your records to another computer.
