<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageMarker.aspx.cs" Inherits="ImageMarker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/interactjs/dist/interact.min.js"></script>
    <script>
        $(document).ready(function () {
            interact('#marker')
                .draggable({
                    onmove: function (event) {
                        var target = event.target,
                            // keep the dragged position in the data-x/data-y attributes
                            x = (parseFloat(target.getAttribute('data-x')) || 0) + event.dx,
                            y = (parseFloat(target.getAttribute('data-y')) || 0) + event.dy;

                        // translate the element
                        target.style.webkitTransform =
                            target.style.transform =
                            'translate(' + x + 'px, ' + y + 'px)';

                        // update the posiion attributes
                        target.setAttribute('data-x', x);
                        target.setAttribute('data-y', y);
                    }
                })
                .resizable({
                    preserveAspectRatio: true,
                    edges: { left: true, right: true, bottom: true, top: true }
                })
                .on('resizeend', function (event) {
                    var target = event.target,
                        x = (parseFloat(target.getAttribute('data-x')) || 0),
                        y = (parseFloat(target.getAttribute('data-y')) || 0);

                    target.style.width = event.rect.width + 'px';
                    target.style.height = event.rect.height + 'px';

                    target.setAttribute('data-x', x);
                    target.setAttribute('data-y', y);
                });
        });

        function SaveMarkerPosition() {
            var x = $('#marker').attr('data-x');
            var y = $('#marker').attr('data-y');
            var width = $('#marker').width();
            var height = $('#marker').height();
            var imageUrl = $('#image').attr('src');

            $.ajax({
                type: "POST",
                url: "SaveMarkerPosition.aspx",
                data: {
                    x: x,
                    y: y,
                    width: width,
                    height: height,
                    imageUrl: imageUrl
                },
                success: function (response) {
                    alert('Marker position saved successfully.');
                },
                error: function () {
                    alert('Error occurred while saving marker position.');
                }
            });
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            height: 310px;
        }
        .auto-style2 {
            position: absolute;
            top: 191px;
            left: 102px;
            width: 14px;
            height: 11px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img id="image" src="images/clmb.png" alt="Image" class="auto-style1" />
            <div id="marker" style="background-color:red;" class="auto-style2"></div>
            <button type="button" onclick="SaveMarkerPosition();">Save</button>
        </div>
    </form>
</body>
</html>