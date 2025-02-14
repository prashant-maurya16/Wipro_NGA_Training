// var http = require("http");
// http
//   .createServer(function (req, res) {
//     res.writeHead(200, { "content-type": "text/html" });
//     res.end("hello World");
//   })
//   .listen(8080);
var express = require("express"); //it will load express framework which will allow with the server
var app = express(); //it represents the express application
app.set("viewengine", "jade"); //viewEngine allows us to rerender dynamic html page
app.get("/", function (req, res) {
  res.send("Hello Express"); // rooturl http://localhost:3000/myapp/
});
var server = app.listen(3000, function () {
  console.log("http listen on the port:3000");
});