#r "Sample.dll"
var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  TestingBuild();
  //MSBuild("./src/CakeDemo.sln");
});

RunTarget(target);