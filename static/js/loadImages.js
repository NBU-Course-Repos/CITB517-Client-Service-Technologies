const IMAGES_LIST_TABLE_ID = "images-table-list"

function loadGalleryImages(){
    const files = getImages()
    const table = document.getElementById(IMAGES_LIST_TABLE_ID)
    var rowsCount = table.rows.length
    for (let i = 0; i<files.length; i++){
        var row = table.insertRow(rowsCount);
        const commentsNumber = Math.floor(Math.random() * 10);
        rowsCount = rowsCount + 1;
        row.innerHTML += `
        <td>
         <div class="image-container">
            <span>${files[i]}</span>
            <img style="" src="../gallery-images/${files[i]}" class="image">
            <div class="image-footer-container">
                <div style="display:flex;">
                    <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-chat-square-dots" viewBox="0 0 16 16">
                    <path d="M14 1a1 1 0 0 1 1 1v8a1 1 0 0 1-1 1h-2.5a2 2 0 0 0-1.6.8L8 14.333 6.1 11.8a2 2 0 0 0-1.6-.8H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1zM2 0a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h2.5a1 1 0 0 1 .8.4l1.9 2.533a1 1 0 0 0 1.6 0l1.9-2.533a1 1 0 0 1 .8-.4H14a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2z"/>
                    <path d="M5 6a1 1 0 1 1-2 0 1 1 0 0 1 2 0m4 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0m4 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0"/>
                    </svg>
                    <a class="share-button-container">${commentsNumber} Comments</a>
                </div>
                <div style="display: flex; padding-left:30px;" >
                    <svg xmlns="http://www.w3.org/2000/svg"
                    width="25" height="25" fill="white"
                    class="bi bi-share-fill" viewBox="0 0 16 16">
                    <path
                        d="M11 2.5a2.5 2.5 0 1 1 .603 1.628l-6.718 3.12a2.499 2.499 0 0 1 0 1.504l6.718 3.12a2.5 2.5 0 1 1-.488.876l-6.718-3.12a2.5 2.5 0 1 1 0-3.256l6.718-3.12A2.5 2.5 0 0 1 11 2.5" />
                    </svg>
                    <a class="share-button-container">Share</a>
                </div>
            </div>
        </div>
    </td>`;
    }
}

function getImages(){
    // TODO Implement a query to the back-end as soon as that is done. Until then it's hard coded
    return ["blender_well.png", "bowling-crash.png", "bowling-pin.png", "bowling-pins.png", "low-poly-pawn.png", "pawn-construction.png", "saber-emitter.png", "untitled.png"]
}

function getImageData(image){
    //TODO GET Request to back end to get comments, likes, etc for an image
}