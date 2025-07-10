# 🎲 DiceRoller

A beautiful, modern dice rolling application built with Blazor Server and Tailwind CSS.

## ✨ Features

- 🎯 **Standard Dice**: Roll d4, d6, d8, d10, d12, and d20
- 🎨 **Custom Dice**: Create number ranges or color-based dice
- 🖥️ **Fullscreen Mode**: Immersive rolling experience
- 📊 **Roll History**: Track your previous rolls
- 🌈 **Beautiful UI**: Modern gradient design with glassmorphism effects
- 📱 **Responsive**: Works on desktop and mobile

## 🚀 Technologies Used

- **Blazor Server** - Interactive web UI framework
- **Tailwind CSS** - Utility-first CSS framework
- **C# .NET 9** - Backend logic
- **SVG Icons** - Scalable dice icons

## 🎮 How to Use

1. **Standard Dice**: Click any standard die (d4-d20) to roll
2. **Custom Dice**: 
   - Click the "+" button to create custom dice
   - Choose between number ranges or color sets
   - Give your dice a name and configure options
3. **Fullscreen Mode**: Click "Fullscreen" on any dice for an immersive experience
4. **History**: View your roll history and clear it when needed

## 🛠️ Development

### Prerequisites
- .NET 9 SDK
- Node.js (for Tailwind CSS)

### Getting Started

1. Clone the repository
```bash
git clone https://github.com/yourusername/DiceRoller.git
cd DiceRoller
```

2. Install dependencies
```bash
# Install .NET packages
dotnet restore

# Install Node.js packages
npm install
```

3. Build Tailwind CSS
```bash
npm run build:tailwind
```

4. Run the application
```bash
dotnet run
```

5. Open your browser to `http://localhost:5075`

## 🎨 Customization

The app uses Tailwind CSS for styling. To customize:

1. Edit the Tailwind classes in the Razor components
2. Rebuild the CSS: `npx tailwindcss -i ./wwwroot/css/tailwind.css -o ./wwwroot/app.css`
3. Restart the application

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 🤝 Contributing

Contributions are welcome! Feel free to submit issues and pull requests.

---

Made with ❤️ and lots of ☕
