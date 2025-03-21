# 🌦️ WeatherWise - Your 8-Day Forecast Companion ☀️


## Overview

WeatherWise is a simple yet powerful weather application that provides you with an 8-day weather forecast for any city you enter.  Get quick access to essential weather information to plan your week effectively.

## ✨ Features

*   **City-Specific Forecast:** Enter the name of any city and instantly retrieve an 8-day weather forecast.
*   **Clear Weather Information:**  See a concise summary of the weather conditions, including:
    *   Main weather condition (e.g., "Clouds", "Rain", "Clear")
    *   Detailed weather description (e.g., "scattered clouds", "light rain")
    *   Day of the week
*   **User-Friendly Interface:**  Enjoy a clean and intuitive interface for easy navigation.

## 🚀 Getting Started

### Prerequisites

*   [.NET Framework/Runtime](link_to_dotnet_download_page) (Specify the required version)
*   Visual Studio (or any compatible IDE)

### Installation

1.  **Clone the repository:**

    ```
    git clone https://github.com/abdul-rehman16/Weather-Application
    cd WeatherWise
    ```

2.  **Open the project in Visual Studio:**

    *   Double-click on the `.sln` file.

3.  **Configure API Key (Important!):**

    *   This application uses the OpenWeatherMap API. You'll need to obtain an API key.
    *   Sign up for a free account at [OpenWeatherMap](https://openweathermap.org/).
    *   Get your API key from your OpenWeatherMap account dashboard.
    *   Replace `"YOUR_API_KEY"` with your actual API key in the `APIkey` variable within the code (usually in the main form's code-behind file).

  
4.  **Build and Run:**

    *   Press `Ctrl + Shift + B` to build the project.
    *   Press `F5` to run the application.

## 💻 Usage

1.  Enter the name of a city in the text box provided.
2.  Click the "Search" button (or equivalent).
3.  The application will display an 8-day weather forecast, showing the weather conditions for each day.

## 🛠️ Technologies Used

*   **Language:** C#
*   **Framework:** .NET Framework (or .NET)
*   **UI:** Windows Forms (or specify your UI framework)
*   **API:** OpenWeatherMap API
*   **JSON Parsing:** Newtonsoft.Json (Json.NET)


*Main Screen*

![Main Screen](link_to_your_main_screen_screenshot)

*Forecast Details*

![Forecast Screen](link_to_your_forecast_screen_screenshot)

## ⚠️ Troubleshooting

*   **"City not found" Error:** Double-check that you have entered the city name correctly. The OpenWeatherMap API might not recognize misspelled city names.
*   **"API Key Invalid" Error:** Ensure that you have correctly entered your OpenWeatherMap API key in the code.  Also, make sure your API key is activated in your OpenWeatherMap account (it may take a few minutes after creation).
*   **Network Errors:** Check your internet connection. The application requires an active internet connection to retrieve weather data.
*   **SSL/TLS errors:** if you have TLS/SSL related issues, please verify .NET version and OS configuration as mentioned previously. Also disabling certificate validation is not recommended.

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1.  Fork the repository.
2.  Create a new branch for your feature or bug fix.
3.  Make your changes and commit them with descriptive messages.
4.  Submit a pull request.



## 👏 Acknowledgements

*   [OpenWeatherMap](https://openweathermap.org/) for providing the weather API.
*   [Newtonsoft.Json](https://www.newtonsoft.com/json) for providing a robust JSON library.
*   And anyone whose code was used // replace if this is true.
