function solve(params) {
    var spaces = /(\w+)\s+(\w+)/g;
    var spacesX = /\s+([>,~,+])\s/g;
    var spacesD1 = /([^\w])\s+([\.,#,\},:,;])/g;
    var spacesD2 = /\s+([\.,#,\{,\},:,;])/g;
    var spacesF = /([\.,#,\{,\},:,;])\s+/g;

    var selectors = {};
    var props = {};
    var result = '';
    for (var i = 0; i < params.length; i++) {
        str = params[i];

       if (str.indexOf('{') > 0) {
                  params[i] = params[i].replace(spaces, "$1 $2");
       params[i] =  params[i].replace(spacesX, '$1');
       params[i] =  params[i].replace(spacesD1, '$1$2');
       //params[i] =  params[i].replace(spacesF, '$1');
       params[i] = params[i].trim();
       str = params[i];
           var selector = str.slice(0, str.length - 1);
           selector = selector.trim();
           if (!selectors[selector]) {
               selectors[selector] = [];
           }
           
       } else if (str.indexOf('}') >= 0) {
           
       }else{
                  params[i] = params[i].replace(spaces, "$1 $2");
                        params[i] =  params[i].replace(spacesX, '$1');
       params[i] =  params[i].replace(spacesD2, '$1');
       params[i] =  params[i].replace(spacesF, '$1');
       params[i] = params[i].trim();
           
                  str = params[i];
           var prop = str.split(':');
           str = str.slice(0, str.length - 1)
           props[selector + prop[0]] = prop[1];
           var ind = selectors[selector].indexOf(prop[0]);
           if (ind >= 0) {
               selectors[selector].splice(ind, 1);
           }
           selectors[selector].push(prop[0]);
       }
    }
     for(var key in selectors){
         result += key + '{';
         for (var index = 0; index < selectors[key].length; index++) {
             var element = selectors[key][index];
             result += element + ':';
             if (index < selectors[key].length - 1) {
                 result += props[key +element];
             } else{
                  result += props[key + element].slice(0, props[key + element].length - 1);
             }
         }
         result += '}';
         
     }
 console.log(result);
 
}

var test = [
    '#the-big-b{',
    '  color: yellow;',
    '  size: big;',
    '}',
    '.muppet{',
    '  powers: all;',
    '  skin: fluffy;',
    '}',
    '     .water-spirit         {',
    '  powers: water;',
    '             alignment    : not-good;',
    '				}',
    'all{',
    '  meant-for: nerdy-children;',
    '}',
    '.muppet      {',
    '	powers: everything;',
    '}',
    'all            .muppet {',
    '	alignment             :             good                             ;',
    '}',
    '   .muppet+             .water-spirit{',
    '   power: everything-a-muppet-can-do-and-water;',
    '}'
];

console.log(solve(test));
