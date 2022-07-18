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

# Bienvenido a Duolingo
Duolingo es una biblioteca de API de Duolingo multiplataforma. Permite obtener información con diversas funciones que ofrece.


## Colaboradores

Gracias a estas personas maravillosas ([emoji clave](https://allcontributors.org/docs/es-es/emoji-key)):

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
		<a href="https://github.com/Taiizor/Duolingo/commits?author=Taiizor" title="Código">💻</a>
		<a href="https://www.taiizor.com" title="Ideas & Planificación, Comentarios">🤔</a>
	</td>
  </tr>
</table>

Este proyecto sigue la especificación de [todos los contribuyentes](https://github.com/all-contributors/all-contributors). ¡Contribuciones de cualquier tipo de bienvenida!

## Partidarios

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
		<a href="https://github.com/Soferity" target="_blank" title="Contenido">🖋</a>
	</td>
  </tr>
</table>

## Utilizar

Paso 1：Agregue una referencia a Duolingo o busque Duolingo en el NuGet;

```Install-Package Duolingo```

Step 2：

- Registre una cuenta en [Duolingo](https://www.duolingo.com/register).

- Cree una instancia de la clase `Duolingo` y proporcione una `Localization`, una `Account` y un `Client`.

```cs
var localization = new Localization() { Language = Languages.ES };
var account = new Account() { Username = "Usuario", Password = "Contraseña" };
var client = new Client() { EncodingType = Encoding.UTF8 };

var duolingo = new Duolingo(localization, account, client);
```

Paso 3：Disfruta de las codificación