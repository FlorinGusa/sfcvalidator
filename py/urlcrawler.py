import requests
from bs4 import BeautifulSoup
import re

def getAllUrls(url:str):
    reqs = requests.get(url);
    soup = BeautifulSoup(reqs.text, 'html.parser')

    urls = [] 
    for link in soup.find_all('a'):
        if(link is not None):
            urls.append(link.get('href'))
    
    return urls

def find_all(pattern, urls):
    r = re.compile('.*' + pattern)
    newlist = filter(r.match, urls)
    return newlist