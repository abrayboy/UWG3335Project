import { Page } from './models/index.js';
import { GetPage } from './service/index.js';

const pages = [
    "About",
    "Apparel",
    "Contact",
    "FAQ",
    "For Sale",
    "Restorations",
    "Services",
    "Videos"
];

let nav = document.createElement("div");
nav.id = "nav";

pages.forEach(pageName => {
    let page = new Page(pageName);

    let navItem = document.createElement("a");
    navItem.className = "nav-item";
    navItem.innerText = pageName;
    navItem.addEventListener("click", e => {
        GetPage(page.PageName);
    });

    nav.appendChild(navItem);

    document.getElementById("nav").appendChild(nav);
    if (page.PageName === "Apparel") {
        let script = document.createElement("script");
        script.scr = page.ScriptName;
        document.body.appendChild(script);
    }

});