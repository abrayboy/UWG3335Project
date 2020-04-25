import { Apparel } from './models/index.js';
import { TOKEN } from './constants/index.js';
console.log("HEREERE");
const buttons = [... document.getElementsByClassName("cart-button")];

buttons.forEach(button => {
    button.addEventListener("click", e => {
        let parent = button.parentNode;
        let name = parent.children[1].innerText;
        let price = parent.children[2].innerText.replace('$', '');

        let item = new Apparel(name, price);

        console.log(item);

        fetch("/api/Apparel.ashx", {
            method: "POST",
            body: JSON.stringify(item),
            headers: {
                Authorization: TOKEN,
                "Content-Type": "application/json"
            }
        })
            .then(res => res.json())
            .then(res => document.getElementById("total").innerText = `$${res}` );
    });
});

document.getElementById("checkout").addEventListener("click", () => alert(` You Just Paid ${document.getElementById('total').innerText}`));