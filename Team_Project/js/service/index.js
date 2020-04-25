export const GetPage = pageName => {
    console.log(pageName);
    fetch(pageName)
        .then(res => res.text())
        .then(res => {
            console.log(res);
            document.getElementById("root").innerHTML = res; 
        });
};