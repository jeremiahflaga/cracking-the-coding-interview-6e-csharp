# Solutions to Exercises in ["Cracking the Coding Interview 6th Edition" of Gayle Laakmann McDowell](https://www.bookdepository.com/Cracking-Coding-Interview-Gayle-Laakmann-McDowell/9780984782857?a_aid=jflaga)



<br />


------------------------------

# C#

#### to create console project

0. create folder `console`

1. `cd console`

2. `dotnet new console`

#### to create test project

0. create folder `test`

1. `cd test`

2. `dotnet new xunit`

#### to run project

`dotnet run`


#### to run test

`dotnet test`




<br />

------------------------------

# NOTES:

## Sept 15, 2018

**"Copying masters is the first step to mastery"**<sup id="footnote-indicator-1">[[1]](#footnote-1)</sup> --- so I decided to just read the solutions (at least during this first reading), starting from page 192, then reimplement/rewrite the code in the solutions in JavaScript, C# and/or perhaps in F# also because I want to learn F#.

I will also try to write tests for the existing code in the solutions part of the book (Michael Feathers calls this kind of tests _"characterization tests"_ in his book ["Working Effectively with Legacy Code"](https://www.bookdepository.com/Working-Effectively-with-Legacy-Code-Michael-Feathers/9780131177055?a_aid=jflaga), page 186).

I determined that writing charaterizations tests for the existing code in the book can be helpful when the question in the exercises is ambiguous. For example, the first exercise question on page 90 was somewhat ambiguous to me. It says, _"Implement an algorithm to determine if a string has all unique characters."_ On first reading, I understood it to mean, _"Write code to determine if a string contains all characters in the alphabet"_ (and that understanding is what drives me when I was writing [my first solution in JavaScript(ch1-arrays-and-strings/2018-04-07_1.1-is-unique.js)](https://github.com/jeremiahflaga/cracking-the-coding-interview-6e/blob/master/ch1-arrays-and-strings/2018-04-07_1.1-is-unique.js) --- which means that that solution is wrong :) .


``` javascript
// Jboy Flaga
// Start: July 4, 2018 10:14 PM
// O(n) algo: traverse string then update map if character occurs
//              then return true if everything in map is true, 
//              return false otherwise

const allEnglishAlphabet = 'abcdefghijklmnopqrstuvwxyz';

function isUnique(strInput) {
    
    var mapOfAlphaWithOccurence = new Map(); // about Map() - https://macwright.org/2017/03/13/maps-not-strictly-better.html#introducing-the-map

    for (let i = 0; i < allEnglishAlphabet.length; i++) {
        const char = allEnglishAlphabet.charAt(i);
        mapOfAlphaWithOccurence.set(char, false);
    }

    for (let i = 0; i < strInput.length; i++) {
        const char = strInput.charAt(i);
        mapOfAlphaWithOccurence.set(char, true);
    }

    for (let key of mapOfAlphaWithOccurence.keys()) {
        if (mapOfAlphaWithOccurence.get(key) === false)
            return false;
    }

    return true;
}

console.log(isUnique("a")); // false
console.log(isUnique(allEnglishAlphabet)); // true
console.log(isUnique("a".repeat(24))); // false
console.log(isUnique("a".repeat(25))); // false
console.log(isUnique(allEnglishAlphabet.repeat(2))); // true

```








<br />
<br />
<br />

------------------------------

<sup id="footnote-1">[[1]](#footnote-indicator-1)</sup> <small>I googled for this quote and found this better, more poetic words by Michael Minkoff in his article ["Three Stages of Learning: How to Become a Master"](https://renewthearts.org/three-stages-of-learning-how-to-become-a-master/): _"Imitation is the beginning of any learning process. The first step in becoming a master is imitating the masters."_</small>
