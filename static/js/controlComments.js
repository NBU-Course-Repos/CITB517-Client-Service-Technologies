function commentVisibility(btnIndex){
    const commentSection = document.getElementById(`comment-section-${btnIndex}`);
    if (commentSection.style.display === 'none'){
        commentSection.style.display = 'flex';
        commentSection.style.visibility = 'unset';
    }
    else{
        commentSection.style.display = 'none';
        commentSection.style.visibility = 'collapse';
    }
}

function submitComment(imgIndex){
    console.log(imgIndex);

    const commentsTable = document.getElementById(`comments-table-${imgIndex}`);
    const commentInput = document.getElementById(`comment-input-${imgIndex}`); 
    const commentText = commentInput.value;
    
    console.log(commentInput);
    console.log(`submitting comment for coment-input-${imgIndex}`);
    console.log(`Value:  ${commentInput.value}`)
    var newComment = commentsTable.insertRow(commentsTable.rows.length);
    newComment.innerHTML = `<td>
        <div style="border: solid black thin; padding-bottom: 1%; margin-bottom: .5%;">
            <div style="display: flex; gap: 10px;" >
                <img src="../profile.png" style="width: 15%; max-width: 50px">
                <p>Antonio</p>
            </div>
            <p>
                ${commentText}
            </p>
        </div>
    </td>`;
    commentInput.value = "";
    console.log(newComment);

}