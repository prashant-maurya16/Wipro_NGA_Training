const express = require("express");

const app = express();
const port = 3000;

app.get("/", (req, res) => {
  res.send("Hello i am get method coming from node js code");
});

app.get("/name", (req, res) => {
  res.send("My name is prashant");
});

app.get("/age", (req, res) => {
  res.send("I am 21 year old");
});

app.get("/contact", (req, res) => {
  res.send("My contact  number is thiss 0000000000");
});

app.listen(port, () => {
  console.log(`server is running: ${port}`);
});
