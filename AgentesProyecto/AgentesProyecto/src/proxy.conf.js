const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/AgentA",
      "/AgentB",
      "/AgentC",
    ],
    target: "https://localhost:7163",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
