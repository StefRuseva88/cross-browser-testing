# CrossBrowser Testing with Selenium, Selenium Grid, Selenoid
[![C#](https://img.shields.io/badge/Made%20with-C%23-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91.svg)](https://dotnet.microsoft.com/)
[![Google Chrome](https://img.shields.io/badge/tested%20on-Google%20Chrome-4285F4.svg)](https://www.google.com/chrome/)
[![Mozilla Firefox](https://img.shields.io/badge/tested%20on-Mozilla%20Firefox-FF7139.svg)](https://www.mozilla.org/firefox/)
[![Microsoft Edge](https://img.shields.io/badge/tested%20on-Microsoft%20Edge-0078D7.svg)](https://www.microsoft.com/edge)
[![Selenoid](https://img.shields.io/badge/tested%20with-Selenoid-4B8BBE.svg)](https://aerokube.com/selenoid/)
[![Selenium Grid](https://img.shields.io/badge/tested%20with-Selenium%20Grid-43B02A.svg)](https://www.selenium.dev/documentation/grid/)
[![NUnit](https://img.shields.io/badge/tested%20with-NUnit-22B2B0.svg)](https://nunit.org/)
[![Selenium](https://img.shields.io/badge/tested%20with-Selenium-43B02A.svg)](https://www.selenium.dev/)
[![Docker](https://img.shields.io/badge/Powered%20by-Docker-2496ED.svg)](https://www.docker.com/)


### This is a test project for Front-End Test Automation July 2024 Course @ SoftUni
---
## Overview

This project demonstrates **cross-browser testing** using **Selenium**, **Selenium Grid**, and **Selenoid** to execute automated tests across multiple browsers and platforms. It is designed to showcase techniques for running distributed tests in parallel, ensuring web applications behave consistently across different environments.

## Tools and Technologies Used

- **Selenium**: For automating web browser interactions and performing functional tests.
- **Selenium Grid**: To distribute and run tests across multiple machines and browsers simultaneously.
- **Selenoid**: For managing browsers in containers and executing tests in a scalable, distributed environment.
- **Docker**: To run and manage Selenoid containers.
- **NUnit**: For structuring and running the test cases.

## Key Features

- **Cross-browser testing** with Chrome, Firefox, and other supported browsers.
- **Parallel execution** of test cases using Selenium Grid and Selenoid for faster test cycles.
- **Containerized testing** environments via Selenoid, allowing for scalable, isolated test sessions.
- **Remote test execution** on multiple nodes to cover various platforms and browsers.
- **Real-time video recording** of test executions for better debugging and reporting.


## Test Scenarios

1. **Browser Automation**  
   Tests basic browser interactions such as navigating to a page, clicking buttons, filling forms, and verifying page elements.
   
2. **Cross-browser Compatibility**  
   Verifies that the web application behaves the same way on different browsers (e.g., Chrome, Firefox, Opera).
   
3. **Parallel Test Execution**  
   Uses Selenium Grid to run multiple tests in parallel across different browser versions and environments.

4. **Headless Browser Testing**  
   Executes tests in headless mode using Selenoid, allowing for faster test execution without opening a GUI browser.

