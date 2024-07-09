// QUESTION 1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
  };

let sum = 0;
for (let key in salaries) {
    sum += salaries[key];
}


// QUESTION 2
var menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(obj) {
    for (let key in obj) {
        if (typeof obj[key] === 'number') {
            obj[key] *= 2;
        }
    }
}
  

// QUESTION 3
function checkEmailId(str) {
    let at = str.indexOf('@');
    let dot = str.indexOf('.');
    
    return at != -1 && dot != -1 && dot < at + 1
}

// QUESTION 4
function truncate(str, maxLen) {
    if (str.length > maxLen) {
      return str.slice(0, maxLen-1) + '...';
    }
    return str;
}


// QUESTION 5
let styles = ["James", "Brennie"];
styles.push("Robert");
styles[Math.floor(styles.length / 2)] = "Calvin";
let head = styles.shift();
styles.unshift("Rose", "Regal");