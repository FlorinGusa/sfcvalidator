import staticscrape
import urlcrawler

sourceUrls = 'https://www.fanuc.eu/'

def main():
    allUrls = urlcrawler.getAllUrls(sourceUrls)
    print(allUrls)
    res = urlcrawler.find_all('legal-notice', allUrls)
    print(list(res))
if __name__ == "__main__":
    main()