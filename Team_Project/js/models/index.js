export function Apparel(name, price)
{
    'use strict';
    this.Name = name;
    this.Price = price;
}

export function Page(name) {
    'use strict';
    this.PageName = name.replace(/ /g, '_') + ".html";
    this.ScriptName = "js/" + name.toLocaleLowerCase() + ".js";
}