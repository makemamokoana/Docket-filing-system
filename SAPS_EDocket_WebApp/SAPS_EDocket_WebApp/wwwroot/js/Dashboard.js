document.addEventListener("DOMContentLoaded", function () {
    // Simulate some basic dashboard functionality
    const totalCases = 150;
    const closedCases = 100;
    const pendingCases = totalCases - closedCases;

    document.querySelector('.stat-card:nth-child(1) p').textContent = totalCases;
    document.querySelector('.stat-card:nth-child(2) p').textContent = pendingCases;
    document.querySelector('.stat-card:nth-child(3) p').textContent = closedCases;
});
