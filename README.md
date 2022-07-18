![Logo](.images/Logo.png)

![Dot-Net-Framework-Version](https://img.shields.io/badge/.NET%20Framework-%3E%3D4.5.2-blue)
![Dot-Net-Standard-Version](https://img.shields.io/badge/.NET%20Standard-%3E%3D1.1-blue)
![Dot-Net-Core-Version](https://img.shields.io/badge/.NET%20Core-%3E%3D3.1-blue)
![Dot-Net-Version](https://img.shields.io/badge/.NET-%3E%3D5.0-blue)
![C-Sharp-Version](https://img.shields.io/badge/C%23-11.0-blue.svg)
![IDE-Version](https://img.shields.io/badge/IDE-VS2022-blue.svg)
[![NuGet-Version](https://img.shields.io/nuget/v/Duolingo.svg)](https://www.nuget.org/packages/Duolingo)
[![FuGet-Version](https://www.fuget.org/packages/Duolingo/badge.svg)](https://www.fuget.org/packages/Duolingo)
[![NuGet](https://img.shields.io/nuget/dt/Duolingo)](https://www.nuget.org/api/v2/package/Duolingo)

[![.NET](https://github.com/Taiizor/Duolingo/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Taiizor/Duolingo/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/Taiizor/Duolingo/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/Taiizor/Duolingo/actions/workflows/codeql-analysis.yml)
[![.NET Desktop](https://github.com/Taiizor/Duolingo/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/Taiizor/Duolingo/actions/workflows/dotnet-desktop.yml)

[![Discord-Server](https://img.shields.io/discord/932386235538878534?label=Discord)](https://discord.gg/nxG977byXb)

# Welcome to Duolingo
Duolingo is a Cross-Platform Duolingo API library. It allows obtaining information with various functions it offers.

## Contributors

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<table>
  <tr>
    <td align="center">
		<a href="https://github.com/Taiizor">
			<img src="https://avatars3.githubusercontent.com/u/41683699?s=460&v=4" width="80px;" alt="Taiizor"/>
			<br/>
			<sub>
				<b>Taiizor</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Taiizor/Duolingo/commits?author=Taiizor" title="Code">💻</a>
		<a href="https://www.taiizor.com" title="Ideas & Planning, Feedback">🤔</a>
	</td>
  </tr>
</table>

This project follows the [all contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!

## Backers

<table>
  <tr>
    <td align="center">
		<a href="https://github.com/Soferity">
			<img src="https://avatars3.githubusercontent.com/u/63516515?s=200&v=4" width="80px;" alt="Soferity"/>
			<br/>
			<sub>
				<b>Soferity</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Soferity" target="_blank" title="Content">🖋</a>
	</td>
  </tr>
</table>

## Usage

Step 1：Add a reference to Duolingo or search for Duolingo on the NuGet;

```Install-Package Duolingo```

Step 2：

- Register an account on [Duolingo](https://www.duolingo.com/register).

- Create an instance of the `Duolingo` class and provide it with either a `Localization`, a `Account` and a `Client`.

```cs
var localization = new Localization() { Language = Languages.EN };
var account = new Account() { Username = "User", Password = "Pass" };
var client = new Client() { EncodingType = Encoding.UTF8 };

var duolingo = new Duolingo(localization, account, client);
```

Step 3：Enjoy encoding