const DummyApi = "https://randomuser.me/api/";

async function DummyData() {
    try {
        const response = await fetch(DummyApi);
        
        if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
        }

        const data = await response.json();

        if (data && data.data) { // Ensure 'data' key exists in response
            console.log("Employee Data:", data.data);
        } else {
            console.warn("Unexpected response format:", data);
        }

    } catch (error) {
        console.error("Error fetching data:", error);
    }
}

DummyData();
