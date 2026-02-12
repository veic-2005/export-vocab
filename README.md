# export-vocab
Exporting vocabulary from MySQL

- FX 4.5+
- MySQL 5.7+

### MySQL
PMC:
```
Update-Package -reinstall
```
Because it needs to support MySQL v5.7, the highest version that can be selected is mysql.data v8.3.0.

- [Connector/NET Requirements for Related Products](https://dev.mysql.com/doc/connector-net/en/connector-net-versions.html)

|Connector/NET Version|.NET Versions|MySQL Server|
|-|-|-|
|C/NET 8.3.0|.NET 8/.NET 7/.NET 6/.NET Framework 4.8/.NET Framework 4.6.2|MySQL 8.3, MySQL 8.0, or MySQL 5.7|

### Dot Net
- [Remarks for version 4.5 and later](https://learn.microsoft.com/en-us/dotnet/framework/install/versions-and-dependencies?source=recommendations#remarks-for-version-45-and-later)

#### Remarks for version 4.5 and later
.NET Framework 4.5 is an in-place update that replaces .NET Framework 4 on your computer, and similarly, 
.NET Framework 4.5.1, 4.5.2, 4.6, 4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, and 4.8 are in-place updates to .NET Framework 4.5. 
In-place update means that they use the same runtime version, but the assembly versions are updated and include new types and members. 
After you install one of these updates, your .NET Framework 4, .NET Framework 4.5, .NET Framework 4.6, 
or .NET Framework 4.7 apps should continue to run without requiring recompilation. However, 
the reverse is not true. We do not recommend running apps that target a later version of .NET Framework on an earlier version. 
For example, we do not recommend that you run an app the targets .NET Framework 4.6 on .NET Framework 4.5.
