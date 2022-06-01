import scrapy


class ContactSpider(scrapy.Spider):
    name = 'contact'

    # todo: import from csharp
    def start_requests(self):
        urls = [
            'https://www.fanuc.eu/de/en/legal-notice',
            'https://www.porsche-stuttgart.de/'
        ]

        # todo: error handling
        for url in urls:
            yield scrapy.Request(url=url, callback=self.parse)


    def parse(self, response):
        res = response.xpath('//a[contains(@href, "mailto")]/@href').re('mailto:([^?]*)')
        print(res)
        pass
