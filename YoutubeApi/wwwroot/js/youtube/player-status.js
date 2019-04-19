var player;
function onYouTubeIframeAPIReady() {
    player = new YT.Player('player', {
        height: '390',
        width: '640',
        videoId: 'jU5i1WjRBhE',
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}

function onPlayerReady(event) {
    window.setInterval(function () {
        showCurrentTime();
    }, 500);
}

function onPlayerStateChange(event) {
    switch (event.data) {
        case -1:
            $('#status').html('State: Not started');
            break;
        case 0:
            $('#status').html('State: Ended');
            break;
        case 1:
            $('#status').html('State: Playing');
            break;
        case 2:
            $('#status').html('State: Paused');
            break;
        case 3:
            $('#status').html('State: Buffering');
            break;
        case 5:
            $('#status').html('State: Video cued');
            break;
        default:
            $('#status').html('Default');
            break;
    }
}

function showCurrentTime() {
    if (player.getPlayerState() === 1) {
        $('#time').html(player.getCurrentTime());
    }
}