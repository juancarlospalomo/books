//Example of creating & using a variable for the string type

//using strict mode, every var has to be declared with var, before used it.  
//see strictmode.js script
'use strict';  

var name = 'Jack';
console.log(name);

//operate with string to concat a value.
//cast the 85 number to string to concat it
name = 'Jack ' + 85;
console.log(name);

//double quotes can be used too to assign a string value to a variable
name = "Jack";
console.log(name);

//you can use single quotes inside double quotes.  
//It is very useful for instance with genitive saxon
name = "Then Jack's name";
console.log(name);

//variables can be dynamically change their types
//with only assign it a value of another type 
console.log(typeof(name)); //string type
name = 1;
console.log(typeof(name)); //number type
