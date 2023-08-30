function formatInput(event, input) {
    const char = String.fromCharCode(event.which);

    if (!/[0-9,.]/.test(char)) {
        event.preventDefault();
    }

    if (char === ',' || char === '.') {
        if (input.value.indexOf(',') !== -1 || input.value.indexOf('.') !== -1) {
            event.preventDefault();
        } else {
            input.value += ',';
            event.preventDefault();
        }
    }

    if (input.value.indexOf(',') !== -1) {
        const parts = input.value.split(',');
        if (parts.length === 2 && parts[1].length >= 3) {
            event.preventDefault();
        }
    }
}

$(document).ready(function () {
    $('.price-cell').each(function () {
        const priceCell = $(this);
        const price = parseFloat(priceCell.attr('data-price'));

        const popoverOptions = {
            content: 'Загрузка...',
            html: true,
        };

        priceCell.popover(popoverOptions);

        priceCell.on('inserted.bs.popover', async function () {
            const popover = $(this).data('bs.popover').tip;
            const popoverContent = await getPopoverContent(price);
            popover.querySelector('.popover-body').innerHTML = popoverContent;
        });
    });
});

async function getPopoverContent(price) {
    const response = await fetch("/ExchangeRate/GetExchangeRate", {
        method: "GET",
        headers: { "Content-Type": " text/plain" },
    });
    const responxeValue = await response.text();
    const convertedPrice = parseFloat(price / responxeValue).toFixed(3);
    return `${convertedPrice}$`;
}