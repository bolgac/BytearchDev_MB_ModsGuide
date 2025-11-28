# Bytearch DEV - Bannerlord Modding Guides

![Bannerlord Modding](https://img.shields.io/badge/Game-Mount%20%26%20Blade%20II%3A%20Bannerlord-blue)
![.NET](https://img.shields.io/badge/.NET-4.7.2-purple)
![C#](https://img.shields.io/badge/C%23-8.0-green)

This repository contains the full source code for **Mount & Blade II: Bannerlord** modding guides. Each project is directly aligned with the articles published on the Bytearch Dev blog.

## Guide List

| Project | Level | Description | Blog Post |
|---------|-------|-------------|-----------|
| [`MyFirstMod`](./MyFirstMod) | 🟢 Beginner | Create your first Bannerlord mod | [First Mod Guide](https://bytearch.dev/getting-started-with-bannerlord-moddingi) |
| *More coming soon...* | | | |

## Quick Start

### Requirements
- [Mount & Blade II: Bannerlord](https://www.taleworlds.com/en/Games/Bannerlord)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- Bannerlord Modding Kit (via Steam)

### Usage
1. Navigate to the desired mod folder  
2. Follow the installation instructions in its README.md  
3. Copy the DLLs into the game’s `Modules` directory  
4. Enable the mod from the Bannerlord launcher  

## Project Structure
```
├── Bannerlord-Modding-Guides/
├────  ModBasic1/
│     ├── Bin/
│     │   └── Win64_Shipping_Client/
│     │       └── MyFirstMod.dll
│     ├── ModBasic1/
│     ├── ModBasic1.csproj
│     ├── SubModule.xml
│     └── README.md
```
## Purpose
This repository contains **guide-level modding examples** for Mount & Blade II: Bannerlord.  
Each folder contains a different mod example (for example: *ModBasic1*, *ModBasic2*). The codes are intended for learning and community sharing.

---

## Common Issues
- **"Could not load file or assembly"** → DLL not in correct folder  
- **"Missing depended module"** → Missing dependency in SubModule.xml  
- **Mod not showing up in list** → XML incorrect  

---

## Contribution
Feel free to open pull requests and issues.  

## Note
- This repository is prepared as a guide for Bannerlord modding.  

## Contacts
- Blog: [Bytearch Dev](https://bytearch.hashnode.dev)
- Telegram: [@bytearchdev](https://t.me/bytearchdev)
- Email: [BytearchDEV](bytearchsoft@gmail.com)
- GitHub: [@bolgac](https://github.com/bolgac/)
