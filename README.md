# 🎲 DiceRoller

Customizeable, modern dice rolling application built with Blazor Server and Tailwind CSS.

## 🚀 Technologies Used

- **Blazor Server** - Interactive web UI framework
- **Tailwind CSS** - Utility-first CSS framework
- **C# .NET 9** - Backend logic
- **SVG Icons** - Scalable dice icons


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

## Customization

The app uses Tailwind CSS for styling. To customize:

1. Edit the Tailwind classes in the Razor components
2. Rebuild the CSS: `npx tailwindcss -i ./wwwroot/css/tailwind.css -o ./wwwroot/app.css`
3. Restart the application


