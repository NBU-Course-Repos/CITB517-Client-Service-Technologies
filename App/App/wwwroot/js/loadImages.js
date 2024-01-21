const IMAGES_LIST_TABLE_ID = "images-table-list"

loadGalleryImages()

function loadGalleryImages(){
    $.get("/rest/api/media/all", function (media) {
        const table = document.getElementById(IMAGES_LIST_TABLE_ID);
        var rowsCount = table.rows.length;
        for (let i = 0; i < media.length; i++){
            var row = table.insertRow(rowsCount);
            const commentsNumber = 0
            rowsCount +=1;
            row.innerHTML += `
            <td>
             <div class="image-container">
                <span>${media[i].caption}</span>
                <img style="" src="${media[i].filePath}" class="image">
                <div class="image-footer-container">
                    <div style="display:flex;">
                    <button onclick=commentVisibility("${media[i].id}") class="comment-button" id="comment-btn-${media[i].id}">
                        <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-chat-square-dots" viewBox="0 0 16 16">
                        <path d="M14 1a1 1 0 0 1 1 1v8a1 1 0 0 1-1 1h-2.5a2 2 0 0 0-1.6.8L8 14.333 6.1 11.8a2 2 0 0 0-1.6-.8H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1zM2 0a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h2.5a1 1 0 0 1 .8.4l1.9 2.533a1 1 0 0 0 1.6 0l1.9-2.533a1 1 0 0 1 .8-.4H14a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2z"/>
                        <path d="M5 6a1 1 0 1 1-2 0 1 1 0 0 1 2 0m4 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0m4 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0"/>
                        </svg>
                    </button>
                    </div>
                    <div style="display: flex; padding-left:30px;">
                        <svg xmlns="http://www.w3.org/2000/svg"
                        width="25" height="25" fill="white"
                        class="bi bi-share-fill" viewBox="0 0 16 16">
                        <path
                            d="M11 2.5a2.5 2.5 0 1 1 .603 1.628l-6.718 3.12a2.499 2.499 0 0 1 0 1.504l6.718 3.12a2.5 2.5 0 1 1-.488.876l-6.718-3.12a2.5 2.5 0 1 1 0-3.256l6.718-3.12A2.5 2.5 0 0 1 11 2.5" />
                        </svg>
                    </div>
                    </div>
                </div>
            </td>`;
            var commentRow = table.insertRow(rowsCount);
            commentRow.style.display = 'none';
            commentRow.style.visibility = 'collapse';
            commentRow.id = `comment-section-${media[i].id}`;
            rowsCount += 1;
            commentRow.innerHTML = `
            <td style="background-color: gray; width: 100%;  margin-left: 5%; margin-right: 5%;" >
                <div class="comment-section">
                    <table id="comments-table-${media[i].id}">
                        <tr>
                            <td>
                                <div>
                                    <form style="display: flex; justify-content: space-between;">
                                        <input class="comment-submition" id="comment-input-${media[i].id}" type="text">
                                        <input type="button" value="Comment" onclick=submitComment("${media[i].id}")>
                                    </form>
                                </div>
                            </td>
                        </tr>
                    </table>  
                </div>
            </td>
            `
            }
    });
}

function getImages(){
     $.get("/rest/api/media/all", function (result) {
         return result
    });
}