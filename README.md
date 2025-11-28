# BytearchDev MB Mods Guide

## Purpose
This repository contains **guide-level modding examples** for Mount & Blade II: Bannerlord.  

Each folder contains a different mod example (for example: *ModBasic1*, *ModBasic2*). The codes are intended for learning and community sharing.

---

## Repository Structure
BytearchDev_MB_ModsGuide/\
│\
├── ModBasic1/\
│   ├── Bin/\
│   │   └── Win64_Shipping_Client/\
│   │       └── MyFirstMod.dll\
│   ├── ModBasic1/\
│   ├── ModBasic1.csproj\
│   ├── SubModule.xml\
│   └── README.md\
│\
├── ModBasic2/\
│   ├── Bin/\
│   │   └── Win64_Shipping_Client/\
│   │       └── ModBasic2.dll\
│   ├── ModBasic2/\
│   ├── ModBasic2.csproj\
│   ├── SubModule.xml\
│   └── README.md \
│\
└── README.md                         # Main documentation\



---

## Getting Started
- Open with Visual Studio 2022  
- Target Framework: **.NET Framework 4.7.2**  
- Build Settings: **Release / x64**  

---

## Testing Steps
- Launch the game  
- See startup message  

---

## ⚠️ Common Issues
- **"Could not load file or assembly"** → DLL not in correct folder  
- **"Missing depended module"** → Missing dependency in SubModule.xml  
- **Mod not showing up in list** → XML incorrect  

---

## 🤝 Contribution
🇬🇧 Feel free to open pull requests and issues.  
