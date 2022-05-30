import re
from urllib.request import urlopen

def runTest():
    url = "https://jobs.porsche.com/index.php?ac=imprint"
    page = urlopen(url)
    html = page.read().decode("utf-8")

    pattern = "<title.*?>.*?</title.*?>"
    match_results = re.search(pattern, html, re.IGNORECASE)
    title = match_results.group()
    title = re.sub("<.*?>", "", title) # Remove HTML tags

    print(title)

# import requests

# URL = "
# page = requests.get(URL)

# print(page.text)