const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/AgentA",
      "/AgentB",
      "/AgentC",
    ],
    target: "https://apisumma.azurewebsites.net/",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
