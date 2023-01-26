## Src_CoreWCF_NET60

Core WCF development procedure to implement in .NET6.0.

I created a sample that connects and communicates between a .Net 6.0 Windows Forms app and Core WCF. Core WCF is the .NET 6.0 (.Net Core) version of WCF.
Core WCF runs on .NET 6.0 or later, and .NET 6.0 can only be developed with VisualStudio2022 or later, so VisualStudio2022 must be installed in advance.
For Core WCF development, you need to install the Visual Studio project template for Core WCF separately.
By executing the install command of CoreWCF.Templates at the command prompt, you can install the VisualStudio project template of Core WCF.

[YouTube](https://youtu.be/qVPfhVwRq0g)
[Source code explanation page](https://blog.unikktle.com/net6-0%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b-core-wcf-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86/)

---

## Src_CoreWCF_NetFramework48

Core WCF development procedure to implement in .NET6.0.

There seems to be little difference between WCF and Core WCF.
CoreWCF can also be implemented on .NET Framework 4.8.

[YouTube](https://youtu.be/qVPfhVwRq0g)
[Source code explanation page](https://blog.unikktle.com/net6-0%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b-core-wcf-%e9%96%8b%e7%99%ba%e6%89%8b%e9%a0%86/)

---

## Src_CoreWCF_NET60_HttpHeader

Get HttpRequest Header information of Core WCF.

I created a sample to get HttpRequest Header information during WCF communication on the .NET 6.0 CoreWCF server side.

[YouTube](https://youtu.be/x4A7NWbp5Ug)
[Source code explanation page](https://blog.unikktle.com/core-wcf-%e3%81%ae-httprequest-header%e6%83%85%e5%a0%b1%e3%82%92%e5%8f%96%e5%be%97/)

---

## Src_CoreWCF_NET60_Dapper_SQLServer_Transaction

Simple and fast DB transaction processing (on SQLServer) implemented in Core WCF.

From Core WCF of .Net 6.0, using Dapper + Microsoft.Data.SqlClient NuGet package, I created a sample that performs DB transaction processing to SQLServer database.
The mainstream of OR mapping is becoming Dapper.

If business logic and database processing are implemented using Repository and Interface, the source code becomes complicated and maintainability decreases.
Implementing with a static class simplifies the source code and improves maintainability.
Unit tests are easy to implement for source code implemented with static classes.

There are too many projects that use repositories and interfaces to implement a large amount of useless processing, exploding man-hours and never ending development. Static should be used.
Even now, there are people who don't understand multithreading in C# and say "I'm worried about using static", and if that person's opinion is adopted and "static is prohibited", the development effort will explode.

[YouTube](https://youtu.be/AGTt9b8B9vs)
[Source code explanation page](https://blog.unikktle.com/core-wcf%e3%81%a7%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%a7%e9%ab%98%e9%80%9f%e3%81%aadb%e3%83%88%e3%83%a9%e3%83%b3%e3%82%b6%e3%82%af%e3%82%b7%e3%83%a7%e3%83%b3/)

---

## Src_WCF_Upgrade_CoreWCF

[YouTube]()
[Source code explanation page]()

---

