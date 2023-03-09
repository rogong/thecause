
    const uri = 'api/signs' + petitionId;
    let signs = [];

    function getSigns() {
        fetch(uri)
            .then(response => response.json())
            .then(
                data => console.log(data)
            )
            .catch(error => console.error('Unable to get items.', error));
    }

    function _displayItems(data) {
        const userId = document.getElementById('userId')
          userId.Text = '';

          _displayCount(data.length);

            data.forEach(item => { })
    }
