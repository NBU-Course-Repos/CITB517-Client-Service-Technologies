function commentVisibility(mediaId){
    const commentSection = document.getElementById(`comment-section-${mediaId}`);
    const commentsTable = document.getElementById(`comments-table-${mediaId}`);
    console.log(mediaId);
    const COMMENTS_PATH = `/rest/api/comment/all/media/${mediaId}`
    if (commentSection.style.display === 'none'){
        commentSection.style.display = 'flex';
        commentSection.style.visibility = 'unset';
        if (commentsTable.rows.length <= 1) {
            $.get(COMMENTS_PATH, function (comments) {
                for (let i = 0; i != comments.length; i++) {
                    let comment = comments[i];
                    console.log(comment.commentatorEmail)
                    console.log(comment.content);
                    var row = commentsTable.insertRow(commentsTable.rows.length);
                    row.innerHTML = `<td>
                <div style="border: solid black thin; padding-bottom: 1%; margin-bottom: .5%;">
                    <div style="display: flex; gap: 10px;" >
                        <img src="/media/user/default.webp" style="width: 15%; max-width: 50px">
                        <p>${comment.commentatorEmail}</p>
                    </div>
                    <p>
                        ${comment.content}
                    </p>
                </div>
            </td>`
                }
            });
        }
    }
    else{
        commentSection.style.display = 'none';
        commentSection.style.visibility = 'collapse';
    }
}

function submitComment(imgIndex) {
    console.log(imgIndex);

    const commentsTable = document.getElementById(`comments-table-${imgIndex}`);
    const commentInput = document.getElementById(`comment-input-${imgIndex}`);

    const commentText = commentInput.value;
    const currentUser = document.getElementById("assume-role-selection").value;

    const COMMENT_API_URL = `/rest/api/comment`
    const requestData = {
        "Content" : commentText,
        "CommentatorEmail" : currentUser,
        "MediaId" : imgIndex}

    $.post({
        url: COMMENT_API_URL,
        data: JSON.stringify(requestData),
        contentType: 'application/json',
        dataType: 'json',
        success: function (result) {
            console.log(result)
            var newcomment = commentsTable.insertRow(commentsTable.rows.length);
            newcomment.innerHTML = `<td>
        <div style="border: solid black thin; padding-bottom: 1%; margin-bottom: .5%;">
            <div style="display: flex; gap: 10px;" >
                <img src="/media/user/default.webp" style="width: 15%; max-width: 50px">
                <p>${currentUser}</p>
            </div>
            <p>
                ${commentText}
            </p>
        </div>
    </td>`;
            commentInput.value = "";
        }
    })

    
}