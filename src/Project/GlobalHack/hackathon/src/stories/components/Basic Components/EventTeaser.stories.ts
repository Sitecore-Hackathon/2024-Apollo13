import { Meta, StoryObj } from '@storybook/react';
import { Default as EventTeaser } from '../../../components/Basic Components/EventTeaser';
const meta = {
  title: 'Components/EventTeaser',
  component: EventTeaser,
  parameters: {
    layout: 'centered',
  },
  tags: ['autodocs'],
  argTypes: {},
} satisfies Meta<typeof EventTeaser>;
export default meta;
type Story = StoryObj<typeof meta>;
export const Teaser: Story = {
  name: 'Event Teaser',
  args: {
    params: {
      styles: '',
    },
    fields: {
      Headline: {
        value: 'Upcoming Events',
      },
      Events: [
        {
          id: 'f3f24e01-ad62-4126-b1f4-de06e8a2ead1',
          url: 'http://cm/Data/Events/hackathonUSA-EU',
          name: 'hackathonUSA EU',
          displayName: 'hackathonUSA EU',
          fields: {
            EventCity: {
              value: 'Philadelphia',
            },
            EventCountry: {
              value: 'USA',
            },
            EventName: {
              value: 'hackathonUSA Europe',
            },
            EventDate: {
              value: '2024-02-08T05:00:00Z',
            },
            LinkToSite: {
              value: {
                href: 'https://www.hackathonUSA.events/',
                text: 'Visit Site',
                linktype: 'external',
                url: 'https://www.hackathonUSA.events/',
                anchor: '',
                target: '',
              },
            },
            Image: {
              value: {
                src: '../../../../images/hackathonUSA-eu.svg',
                alt: '',
              },
            },
            EventState: {
              value: 'PA',
            },
          },
        },
        {
          id: '7cb5c353-af74-4230-9803-93f1bd41625b',
          url: 'http://cm/Data/Events/hackathonUSA-NA',
          name: 'hackathonUSA NA',
          displayName: 'hackathonUSA NA',
          fields: {
            EventCity: {
              value: 'Pittsburg',
            },
            EventCountry: {
              value: 'USA',
            },
            EventName: {
              value: 'hackathonUSA North America',
            },
            EventDate: {
              value: '2024-02-06T05:00:00Z',
            },
            LinkToSite: {
              value: {
                href: 'https://www.hackathonUSA.events/',
                text: 'Visit Site',
                linktype: 'external',
                url: 'https://www.hackathonUSA.events/',
                anchor: '',
                target: '',
              },
            },
            Image: {
              value: {
                src: '../../../../images/hackathonUSA-eu.svg',
                alt: '',
              },
            },
            EventState: {
              value: 'PA',
            },
          },
        },
        {
          id: 'f3f24e01-ad62-4126-b1f4-de06e8a2ead1',
          url: 'http://cm/Data/Events/hackathonUSA-EU',
          name: 'hackathonUSA EU',
          displayName: 'hackathonUSA EU',
          fields: {
            EventCity: {
              value: 'Philadelphia',
            },
            EventCountry: {
              value: 'USA',
            },
            EventName: {
              value: 'hackathonUSA Europe',
            },
            EventDate: {
              value: '2024-02-08T05:00:00Z',
            },
            LinkToSite: {
              value: {
                href: 'https://www.hackathonUSA.events/',
                text: 'Visit Site',
                linktype: 'external',
                url: 'https://www.hackathonUSA.events/',
                anchor: '',
                target: '',
              },
            },
            Image: {
              value: {
                src: '../../../../images/hackathonUSA-eu.svg',
                alt: '',
              },
            },
            EventState: {
              value: 'PA',
            },
          },
        },
        {
          id: '7cb5c353-af74-4230-9803-93f1bd41625b',
          url: 'http://cm/Data/Events/hackathonUSA-NA',
          name: 'hackathonUSA NA',
          displayName: 'hackathonUSA NA',
          fields: {
            EventCity: {
              value: 'Pittsburg',
            },
            EventCountry: {
              value: 'USA',
            },
            EventName: {
              value: 'hackathonUSA North America',
            },
            EventDate: {
              value: '2024-02-06T05:00:00Z',
            },
            LinkToSite: {
              value: {
                href: 'https://www.hackathonUSA.events/',
                text: 'Visit Site',
                linktype: 'external',
                url: 'https://www.hackathonUSA.events/',
                anchor: '',
                target: '',
              },
            },
            Image: {
              value: {
                src: '../../../../images/hackathonUSA-eu.svg',
                alt: '',
              },
            },
            EventState: {
              value: 'PA',
            },
          },
        },
      ],
    },
  },
};
