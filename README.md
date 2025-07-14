# My MCP Server

Welcome to **My MCP Server** — a modular, developer-friendly Minecraft Coder Pack (MCP) server implementation!

## 📝 Overview

**My MCP Server** provides a robust, customizable, and easy-to-extend foundation for running and developing Minecraft servers built with the MCP toolkit.

## 🚀 Installation

### 1. Install .NET

Download and install the [.NET SDK](https://dotnet.microsoft.com/download) for your OS.

Verify installation in your terminal:
```zsh
dotnet --version
```

### 2. Clone the Repository

```bash
git clone https://github.com/dilushamadushan/my-mcp-server.git
cd my-mcp-server
cd MyMcpServer
```

### 3. Build the Project

```bash
dotnet build
```

### 4. Run the Server

```bash
dotnet run --project MyMcpServer.csproj
```

### 5. Add the Tool in Copilot Chat

> **Note:** Before adding the tool in Copilot Chat, make sure your MCP server is running.

1. Open Copilot Chat in VS Code.
2. Click the **gear icon** (⚙️) or the **"Add Tool"** button.
3. Select your MCP server (`MCP server Name`) from the list.

## 🛠️ Tools Available

You can call these MCP tools from a compatible client:

### 🔹 SayHello
```bash
Command: SayHello
Response: Hello from the MCP Server!
```

### 🔹 Echo
```bash
Command: Echo
Input: "This is a test"
Response: You said: This is a test
```

### 🔹 Greet
```bash
Command: Greet
Input: "Dilusha"
Response: Hello, Dilusha!
```

## 🤝 Contributing

Contributions are welcome!  
To get started:

1. **Fork the repository**
2. **Create a new branch:**  
   `git checkout -b feature/my-feature`
3. **Commit your changes:**  
   `git commit -am 'Add a new feature'`
4. **Push to your fork:**  
   `git push origin feature/my-feature`
5. **Open a Pull Request** on GitHub

---

Enjoy building your Minecraft server with My MCP Server! 🌟
