# DataModelGenerator

C# Program to generate model class from Database Table (MSSQL or MYSQL) (.net framework 4.8)

## Donation

If this project helped you reduce time to develop, please consider buying me a cup of coffee :)

<a href="https://www.buymeacoffee.com/ongyishen" 
target="_blank">
<img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" 
alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

## Screenshot
<img src="https://github.com/ongyishen/DataModelGenerator/blob/main/Sample.gif?raw=true" />

## Sample MSSQL Northwind Database Scripts [instnwnd.sql](https://github.com/ongyishen/DataModelGenerator/blob/main/instnwnd.sql)

## Sample Connection String
### MSSQL
#### Standard Security
```
Server=(local);Database=Northwind;User Id=sa;Password=sa;
```

#### Trusted Connection
```
Server=(local);Database=Northwind;Trusted_Connection=True;
```

### MYSQL
#### Standard Security
```
Server=localhost;Database=northwind;Uid=root;Pwd=123456;
```

## Thanks to following NuGet Package

[SqlSugar](https://github.com/donet5/SqlSugar)

[FastColoredTextBox](https://github.com/PavelTorgashov/FastColoredTextBox)

