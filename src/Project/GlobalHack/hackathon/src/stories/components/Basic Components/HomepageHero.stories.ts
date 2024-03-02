import { Meta, StoryObj } from '@storybook/react';
import { HeroHomepage } from '../../../components/Basic Components/Hero';
const meta = {
  title: 'Components/Hero',
  component: HeroHomepage,
  parameters: {
    layout: 'centered',
  },
  tags: ['autodocs'],
  argTypes: {},
} satisfies Meta<typeof HeroHomepage>;
export default meta;
type Story = StoryObj<typeof meta>;
export const Homepage: Story = {
  name: 'Hero Homepage',
  args: {
    params: {
      styles: '',
    },
    fields: {
      Headline: {
        value: 'An event from the community for the community',
      },
      EventDate: {
        value: 'October 5-6th',
      },
      Text: {
        value:
          'Get ready to experience the ultimate Sitecore conference of the year at hackathonUSA North America in Minneapolis, Minnesota.',
      },
      CallToAction: {
        value: {
          href: 'https://www.sitecore.com',
          anchor: 'Register now',
        },
      },
      Image: {
        value: {
          src: 'https://picsum.photos/1200/800',
        },
      },
    },
  },
};
