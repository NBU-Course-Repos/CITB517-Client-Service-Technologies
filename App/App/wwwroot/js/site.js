$.get("/rest/api/user/all", function (result) {

    let assume_role_selection = document.getElementById("assume-role-selection");
    for (let i = 0; i != result.length; i++) {
        assume_role_selection.innerHTML +=
            `<option value=${result[i].email}>${result[i].email}</option>`
    }
});