//This script ilustrates how to use callback functions

//Sum operator function
function sum(x, y) {
    return x + y;
}

//Substract operator function
function subs(x, y) {
    return x - y;
}

//Make the operation and call the callback function passed in %res% parameter
function doOperation(op, operator, res) {
    var result = op;
    //call to the callback function
    res(operator, result);
}

//it sends the output to the stdout
function logResult(operation, result) {
    console.log(operation + " " + result);
}

console.log("1.- Execute a sum");
console.log("2.- Execute a substraction");

//open the stdin stream
var stdin = global.process.openStdin();
//set encoding to utf8 to receive the stream as a string
stdin.setEncoding('utf8');

stdin.on('data', function (chunk) {
    //data have arrived from stdin
    if (chunk != null) {
        var value = chunk.trim();
        switch (value) {
            case '1':
                doOperation(sum(20, 5), 'sum', logResult);
                break;
            case '2':
                doOperation(subs(20, 5), 'substract', logResult);
                break;
        }
        stdin.emit('end');
    }
});

stdin.on('end', function () {
    console.log('end');
});
    
