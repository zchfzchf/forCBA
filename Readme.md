1> Visual Studio 2022 C#
2> Make sure the following package are installed:
<PackageReference Include="BoDi" Version="1.5.0" />
<PackageReference Include="DotNetSeleniumExtras.PageObjects" Version="3.11.0" />
<PackageReference Include="DotNetSeleniumExtras.PageObjects.Core" Version="4.0.1" />
<PackageReference Include="DotNetSeleniumExtras.WaitHelpers" Version="3.11.0" />
<PackageReference Include="FluentAssertions" Version="6.5.1" />
<PackageReference Include="Gherkin" Version="22.0.0" />
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.1.0" />
<PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
<packageReference Include="NUnit" version="3.13.2" />
<packageReference Include="NUnit3TestAdapter" version="4.2.1" />
<PackageReference Include="Selenium.Support" Version="4.1.0" />
<PackageReference Include="Selenium.WebDriver" Version="4.1.0" />
<PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="100.0.4896.6000" />
<PackageReference Include="Selenium.WebDriver.GeckoDriver" Version="0.31.0" />
<PackageReference Include="SpecFlow" Version="3.9.52" />
<PackageReference Include="SpecFlow.Internal.Json" Version="1.0.8" />
<PackageReference Include="SpecFlow.NUnit" Version="3.9.52" />
<PackageReference Include="SpecFlow.Tools.MsBuild.Generation" Version="3.9.52" />
<PackageReference Include="System.IO" version="4.3.0" />
<PackageReference Include="System.Net.Http" version="4.3.4" />
<PackageReference Include="System.Runtime" version="4.3.1" />
<PackageReference Include="System.Runtime.CompilerServices.Unsafe" version="6.0.0" />
<PackageReference Include="System.Security.Cryptography.Algorithms" version="4.3.1" />
<PackageReference Include="System.Security.Cryptography.Encoding" version="4.3.0" />
<PackageReference Include="System.Security.Cryptography.Primitives" version="4.3.0" />
<PackageReference Include="System.Security.Cryptography.X509Certificates" version="4.3.2" />
<PackageReference Include="System.Threading.Tasks.Extensions" version="4.5.4" />
<PackageReference Include="System.ValueTuple" version="4.5.0" />
3> Create folder \ZCovid19Game
4> Pull all the files to this folder
5> Double click \ZCovid19Game\COVID19Game\COVID19Game.sln to open
6> Caution: check whether the username in SignUp.feature (in folder Features in the project COVID19Game) exists first:
      a> Yes. Change the value to a non-existing username
      b> No. Go to step 7>
7> Click menu Test-> Run all Tests
